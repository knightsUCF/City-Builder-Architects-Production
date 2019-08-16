AWS Game Servers


https://medium.com/plapadoo/spawning-game-servers-on-aws-a391ca78e4ee


To us, the most interesting thing about game development is that you have to master many different disciplines of software engineering. E.g. when developing a multiplayer online game, you not only have to think about how you write your net code, but also how to match your players and how to make your servers available all over the world at low latency. We used AWS to create a global on-demand server infrastructure for our game called reaktron.
Matching Slow - Playing Fast
For reaktron, we are running a matchmaking server which is queried by players to find adversaries to play against. When this server receives a request, it matches players to form a group of regionally close players and starts an instance of the actual game server which is then used by the matched group to play on. This is illustrated in the following picture.

Matchmaking
Players contact the matchmaking server to find them a game.
The matchmaking server matches the players to groups and spawns a game server for each group in their region.
The matchmaking server waits for the game server to be started and returns the IP and port to the players.
The groups connect to their servers.
So, while the matchmaking server needs to be running 24 hours a day, 7 days a week, the game server instances are only started on demand. When a game ends, the game server instance shuts itself down. Also, latency with the game server instances is critical for the in-game experience while high latency during matchmaking won’t be noticed. This means game servers have to run regional, matchmaking servers can run anywhere.
Cloud Hosted Game Servers
By hosting our game servers with AWS, we achieve three things:
Deploy a world-wide, scalable, low-latency infrastructure without renting servers from different providers all over the world
Don’t administer hundreds of servers
Only pay when someone plays our game
Since the matchmaking server can run anywhere, we will focus on how to get the game server running on AWS.
To run the game server Docker images, we opted in for AWS Elastic Compute Cloud (ECS) using Fargate. ECS is Amazon’s solution to run Docker containers. Fargate is a special agent to start and stop the containers, which comes with some pros and cons:
Fargate is not available in every AWS region (but in many)
With Fargate, you avoid running your own Docker daemon on an AWS EC2 instance (this is a big advantage since the EC2 instance would have to run 24/7)
You cannot use AWS Elastic Block Storage (EBS) when running your containers using Fargate
Our idea was to use the AWS SDK within the matchmaking server to dynamically start instances of the game server with ECS/Fargate. To be able to do this, we first had to set some things up:
For each region, we created an ECS cluster to run the containers
We wrote an ECS task definition for Fargate to know how to start the containers
We built the Docker image of our game server and pushed it into an AWS Elastic Container Registry (ECR)
Hint: It is advisable to use AWS Cloud Formation to set these things up. This way, you can automate creating uniform stacks in different regions.
After implementing and running our first version of the container-spawning matchmaking server, we noticed that starting the game servers took too long. We could not let our players wait two minutes for their match to start. Looking into it, we found two main reasons:
Since our game is Steam-based, the game server instances had to run a Steam update on startup which took about 40 seconds. Updating Steam on each launch is necessary because the game server instances don’t get re-used.
It took Fargate a long time to receive our Docker Image from the registry before it could go ahead and start the container.
Optimizing Fargate Container Starting Times
To address the latter, we first stripped down our game server Docker image as much as possible. Second, we decided to use regional ECRs instead of just one ECR. So when the matchmaking server starts a game server in London, Fargate now also pulls the docker image from a London-based ECR instead of the central international one which speeds up things quite a bit.
To solve the problem with the slow steam update, we created AWS Simple Storage Service (S3) Buckets in all regions and built a simple service which, when started, updates steam, pushes the updated files to all of the S3 buckets and then shuts itself down. We dockerized this service as well and configured Fargate to run it once a day. We then updated the game servers to download the steam files from the S3 bucket in their region instead of running a steam update themselves. This brought the actual game server starting time down from 40 to about 3 seconds. However, there will be some Fargate overhead you cannot get rid of.
We ended up with Fargate taking about 30 seconds to start our game servers, which is acceptable. This time varies a bit, depending on whether the cluster is “hot” or “cold” when starting a container.
Saving Data From Short-Lived Container Instances
As our game servers store the played levels, we created another S3 bucket to which the game servers upload their data when a match has ended. Since this is not time-critical anymore, a shared global S3 bucket can be used, as opposed to the regional buckets which have to be used to download the steam files when the game server starts up. It would be preferable to use an EBS volume instead of all these S3 buckets, but since that is not supported by Fargate at the time of writing, we have to fall back to S3.
Low Latency, Low Cost, Low Maintenance
Our takeaway is that you can dynamically spawn game server instances using AWS ECS Fargate as long as your game server is not too large. Our game server docker image is about 70 MB in size. One can and should use AWS Cloud Formation to describe and roll-out the server landscape in different regions. We are happy with the latency of the game servers and we only pay for the time users play our game. Also, we don’t have to maintain our own docker daemons or clusters.

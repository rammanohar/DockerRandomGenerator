
cd C:\DockerRandomGenerator
clear
# Create Image for WebApi
docker build --tag corewinimage:webapi --file .\Docker.RandomGenerator.Api\Dockerfile .
# Create Image for Web MVC
docker build --tag corewinwebimage:webmvc --file .\Docker.RandomGenerator.WebApp\Dockerfile .
#Create the network
docker network ls

docker network create --driver nat apiwebnat-mynetwork

#docker create api container
docker run --name randomcoreapi --publish 6666:80 --network apiwebnat-mynetwork corewinimage:webapi

#docker create web container
docker run --name dotnetcorewin.web --publish 8888:80 --network apiwebnat-mynetwork dotnetcorewin.web:webmvc


#docker Push
docker login
docker image ls
#tag the image first to make it private 
#docker tag firstimage YOUR_DOCKERHUB_NAME/firstimage
#docker push YOUR_DOCKERHUB_NAME/firstimage


docker tag dockerrandomgeneratorapi:webapi prammanohar/dockerrandomgeneratorapi:webapi
docker push prammanohar/dockerrandomgeneratorapi:webapi

docker tag dockerrandomgeneratorapp:webapp prammanohar/dockerrandomgeneratorapp:webapp
docker push prammanohar/dockerrandomgeneratorapp:webapp

#docker build
cd C:\DockerRandomGenerator
docker image ls
docker network ls
docker container ls


#remove Images
docker rmi --force dotnetcorewin.api:webapi
docker rmi --force dotnetcorewin.web:webmvc
docker rmi --force 749882d6f2ff
docker rmi --force 2ed37bd60ceb

#Remove containers 
docker rm /dotnetcorewin.web

docker rm --force dockerrandomgenerator_staging-randomgenerator-api_1 
docker rm --force dockerrandomgenerator_staging-randomgenerator-webapp_1

docker run --name dotnetcorewin.web --publish 8888:80 --network apiwebnat-mynetwork dotnetcorewin.web:webmvc

#Docker Compose 
cd C:\DockerRandomGenerator
dir
clear
docker-compose  up --build

#docker remove docker network rm
clear
docker network ls
docker network rm apiwebnat-mynetwork
[![.NET Foundation](https://img.shields.io/badge/.NET%20Foundation-blueviolet.svg)](https://www.dotnetfoundation.org/)

XDPrueba App
============

A sample app to demonstrate how to connect a web api to a postgres database using docker containers

Getting started
---------------

Download [Docker Desktop](https://www.docker.com/products/docker-desktop) for Mac or Windows. [Docker Compose](https://docs.docker.com/compose) will be automatically installed. On Linux, make sure you have the latest version of [Compose](https://docs.docker.com/compose/install/). 

## Linux and windows containers

Clone this repo
```
git clone --recursive https://github.com/omargzmt/XDPrueba.git

```

You can build from source using:
```
docker-compose build
```

Run in this folder

```
cd XDPrueba
docker-compose up -d
```


This app will be running in port 3000 at [http://localhost:3000](http://localhost:3000) and the get method will be in: [http://localhost:3000/api/Person](http://localhost:3000/api/Person)


## Notes

This app is for testing and demonstrative purposes only.
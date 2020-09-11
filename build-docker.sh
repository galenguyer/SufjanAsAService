#!/usr/bin/env bash
# build, tag, and push docker images

# exit if a command fails
set -o errexit

# exit if required variables aren't set
set -o nounset

cd SufjanAsAService
docker build -f Dockerfile -t docker.galenguyer.com/chef/sufjanasaservice:latest -t sufjanasaservice:latest ..
docker push docker.galenguyer.com/chef/sufjanasaservice:latest

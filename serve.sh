#!/bin/bash

( trap 'kill 0' SIGINT; 
  dotnet run --project backend  &
  npm run --prefix frontend/ serve
)

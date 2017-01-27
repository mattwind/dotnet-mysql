#!/bin/bash

dotnet build
clear
dotnet ./bin/Debug/netcoreapp1.0/dotnet-mysql.dll

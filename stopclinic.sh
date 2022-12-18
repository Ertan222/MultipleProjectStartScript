#! /bin/bash

killpids=$(pgrep -f "dotnet run")
kill $killpids

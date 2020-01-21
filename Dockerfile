FROM mcr.microsoft.com/dotnet/core/runtime:2.2

COPY Cli/bin/Release/netcoreapp2.2/publish app/

ENTRYPOINT ["dotnet", "app/Cli.dll"]

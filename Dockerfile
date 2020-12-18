FROM mcr.microsoft.com/dotnet/core/aspnet:2.2 AS base
WORKDIR /app


FROM mcr.microsoft.com/dotnet/core/sdk:2.2 AS build
WORKDIR /src
COPY . .

FROM build AS publish
RUN dotnet publish "eMuzickiStudio.WebAPI" -c Release -o /app
FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ADD /UsedImages img/

ENTRYPOINT ["dotnet", "eMuzickiStudio.WebAPI.dll"]
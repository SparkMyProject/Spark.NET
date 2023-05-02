FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Spark.NET.AI/Spark.NET.AI.csproj", "Spark.NET.AI/"]
RUN dotnet restore "Spark.NET.AI/Spark.NET.AI.csproj"
COPY . .
WORKDIR "/src/Spark.NET.AI"
RUN dotnet build "Spark.NET.AI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Spark.NET.AI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Spark.NET.AI.dll"]

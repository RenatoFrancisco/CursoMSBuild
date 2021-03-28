FROM mcr.microsoft.com/dotnet/sdk
COPY . source
RUN dotnet publish "source/web/FinancasWeb.csproj"  -o /app -c Release
ENTRYPOINT ["dotnet", "/app/FinancasWeb.dll"]
EXPOSE
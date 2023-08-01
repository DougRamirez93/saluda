
# Se establece la imagen base
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS saludoB

# Se establece el directorio de trabajo
WORKDIR webApiSaludoB

# Se expone el puerto en el que se ejecutará la API
EXPOSE 80

# Se copia el archivo csproj y restaura las dependencias
COPY ./*.csproj ./
RUN dotnet restore

# Se copia los archivos fuente y compila la aplicación
COPY . ./
RUN dotnet publish -c Release -o out

# Se establece la imagen base final
FROM mcr.microsoft.com/dotnet/sdk:6.0 
WORKDIR /webApiSaludoB
COPY --from=saludoB /webApiSaludoB/out .

# Inicia la aplicación
ENTRYPOINT ["dotnet", "WebApiA.dll"]
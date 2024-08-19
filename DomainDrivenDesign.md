# DDD
### Criar solução
```bash 
dotnet new sln -n ScrumFlush 
```
### Criar Projetos
```bash 
dotnet new classlib -n ScrumFlush.Service 
```
### Adicionar os Projetos à Solução
```bash 
dotnet sln ScrumFlush.sln add ScrumFlush.Domain/ScrumFlush.Domain.csproj 
```
```bash 
dotnet sln ScrumFlush.sln add ScrumFlush.Application/ScrumFlush.Application.csproj 
```
```bash 
dotnet sln ScrumFlush.sln add ScrumFlush.Infrastructure/ScrumFlush.Infrastructure.csproj 
```
```bash 
dotnet sln ScrumFlush.sln add ScrumFlush.Api/ScrumFlush.Api.csproj 
```
```bash 
dotnet sln ScrumFlush.sln add ScrumFlush.Service/ScrumFlush.Service.csproj 
```

### Configurar Referências entre Projetos
```bash 
dotnet add ScrumFlush.Application/ScrumFlush.Application.csproj reference ScrumFlush.Domain/ScrumFlush.Domain.csproj
dotnet add ScrumFlush.Application/ScrumFlush.Application.csproj reference ScrumFlush.Service/ScrumFlush.Service.csproj 
```

```bash 
dotnet add ScrumFlush.Infrastructure/ScrumFlush.Infrastructure.csproj reference ScrumFlush.Application/ScrumFlush.Application.csproj
dotnet add ScrumFlush.Infrastructure/ScrumFlush.Infrastructure.csproj reference ScrumFlush.Domain/ScrumFlush.Domain.csproj
dotnet add ScrumFlush.Infrastructure/ScrumFlush.Infrastructure.csproj reference ScrumFlush.Service/ScrumFlush.Service.csproj 
```

```bash 
dotnet add ScrumFlush.Api/ScrumFlush.Api.csproj reference ScrumFlush.Infrastructure/ScrumFlush.Infrastructure.csproj 
```

### Adicionar Dependências e Pacotes
```bash 
dotnet add ScrumFlush.Infrastructure/ScrumFlush.Infrastructure.csproj package Microsoft.EntityFrameworkCore 
```

# GeometryUtils

GeometryUtils é uma biblioteca em C# que fornece funções para criar e manipular polígonos, bem como calcular distâncias entre eles. A biblioteca usa a NetTopologySuite para operações geométricas.

## Sumário

- [Instalação](#instalação)
- [Uso](#uso)
- [Testes](#testes)
- [Dependências](#dependências)
- [Licença](#licença)

## Instalação

1. Clone o repositório para sua máquina local:
    ```sh
    git clone https://github.com/seu-usuario/GeometryUtils.git
    ```

2. Navegue até o diretório do projeto:
    ```sh
    cd GeometryUtils
    ```

3. Restaure os pacotes NuGet:
    ```sh
    dotnet restore
    ```

## Uso

### Criando um Polígono

Você pode criar um polígono usando a função `CreatePolygon`. A função recebe dois arrays de doubles que representam as coordenadas x e y dos vértices do polígono.

```csharp
var polygon = GeometryUtils.CreatePolygon(new[] { 2.0, 6.0, 6.0, 2.0, 2.0 }, new[] { 3.0, 3.0, 5.0, 5.0, 3.0 });
```

### Calculando a Distância entre Polígonos

Para calcular a distância mínima entre dois polígonos, use a função `CalculateDistance`.

```csharp
var polygon1 = GeometryUtils.CreatePolygon(new[] { 2.0, 6.0, 6.0, 2.0, 2.0 }, new[] { 3.0, 3.0, 5.0, 5.0, 3.0 });
var polygon2 = GeometryUtils.CreatePolygon(new[] { 9.0, 12.0, 10.0, 7.0, 9.0 }, new[] { 5.0, 8.0, 10.0, 7.0, 5.0 });

double distance = GeometryUtils.CalculateDistance(polygon1, polygon2);
Console.WriteLine($"Distância mínima entre os polígonos: {distance}");
```

## Testes

Este projeto inclui testes unitários para garantir o funcionamento correto das funções. Os testes estão localizados na pasta `tests` e podem ser executados usando o comando `dotnet test`.

### Testes Unitários Incluídos

- **TestCheckAreaLessOrEqualsTo10m2**: Verifica se a área dos polígonos é menor ou igual a 10 m².
- **TestCheckColumnsInsideTerrain**: Verifica se os polígonos estão dentro de uma área específica (terreno).
- **TestCheckSpaceBetweenColumns**: Verifica se há espaço suficiente entre os polígonos.
- **TestsCheckColumnsRectangular**: Verifica se os polígonos são retangulares.

### Executando os Testes

Para executar os testes, use o seguinte comando:

```sh
dotnet test
```

## Dependências

Este projeto depende das seguintes bibliotecas:

- **NetTopologySuite**: Biblioteca para operações geométricas.
- **xUnit**: Framework de testes para .NET.

Para instalar as dependências, certifique-se de restaurar os pacotes NuGet:

```sh
dotnet restore
```

## Licença

Este projeto está licenciado sob a licença MIT. Veja o arquivo [LICENSE](LICENSE) para mais detalhes.

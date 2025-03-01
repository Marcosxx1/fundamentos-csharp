dotnet --list-sdks lsitar os sdks

Podemos escolher a versão do sdk criando um arquivo **global.json** na raiz da pasta

```json
{
  "sdk": {
    "version": "6.x.x"
  }
}
```

Caso nenhum arquivo global.json for encontrado, ou o arquivo globaljson não especificar uma versãodo SDK, a versão 
**mais recente do SDK instalada será utilizada**
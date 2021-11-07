# (WIP) Unofficial dotnet-template for nez

Creates a FNA/Monogame based Nez project.

Documentation on manual setup and prerequisites can be found in the official repositories: 
- [FNA-FSCode-Template](https://github.com/prime31/FNA-VSCode-Template#fna-vscode-template) 
- [Nez Repository](https://github.com/prime31/Nez#setup)
- [FNA Documentation](https://github.com/FNA-XNA/FNA/wiki/1:-Download-and-Update-FNA)

##How to install ##

```
git clone https://github.com/Tobi-Mob/Nez-Templates.git -depth 1
dotnet new --install Nez-Templates/Template
```

## How to use ##
Create a FNA based Project

`dotnet new nez -o MyGame`

Create a Monogame base Project

`dotnet new nez -o MyGame -f MG38`
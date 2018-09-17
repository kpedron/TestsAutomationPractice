Este projeto de automacao de testes tem como objetivo validar algumas funcionalidades da pagina: http://automationpractice.com/index.php

*** Versoes Utilizadas ***
Visual Studio 15.8.1
VisualStudio.15.Release/15.8.1+28010.2003
Microsoft .NET Framework Version 4.7.03056
ASP.NET and Web Tools 2017   15.8.05074.0
ASP.NET Core Razor Language Services   15.8.31590
ASP.NET Web Frameworks and Tools 2017   5.2.60618.0
Azure App Service Tools v3.0.0   15.8.05023.0
Azure App Service Tools v3.0.0
C# Tools   2.9.0-beta8-63208-01

*** Execucao ***
==> Testes elaborados com o NUNIT 3.10.1
==> Selenium WebDriver 3.14.0

Para executar os testes você pode utilizar a propria interface do Visual Studio.
Para isso carregue este projeto no VS e va na aba Test - Run - All Tests.

*** Configuracoes ***
A qualquer momento você pode alterar os parâmetros de teste no arquivo App.config. Obedecendo a configuracao XML.

==> IMPORTANTE <==
Em Tests/App.config existe a chave "product_id", eh nesta chave que voce ira dizer qual produto da loja deseja comprar.
Para descobrir qual eh o id, acesse um produto da pagina e leia a descricao do produto, como "Model  demo_3". 
Neste exemplo o "product_id" sera 3. Colete tambem o valor do produto e insira na chave "product_price", utilizando
inclusive o "$".

==> LEMBRETE <==
Apos criar uma conta no site, nao sera mais possivel cadastrar este usuario, portanto, para rodar novamente os testes
altere o email do usuario na chave "user_email" em App.config.
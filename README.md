# Repositório de exemplo

# Para configurar o GIT em seu computador:

- **Passo 1 - Executar o programa** **"Git Bash"**

	Caso **não** tenha o programa em seu computador, realize o download do site: https://git-scm.com/download/win
	
		(Utilize a versão Portable)
		
		Git for Windows Portable ("thumbdrive edition")
			- 32-bit Git for Windows Portable.
			- 64-bit Git for Windows Portable.
			

- **Passo 2 - Escolha o diretório de trabalho no Git Bash**
	
		Exemplo: 	
			cd e:
			cd jogos
				

- **Passo 3 - Configurar o proxy no git (Se estiver em uma rede com PROXY):**
	
	COMANDO PADRÃO (não executar este):
	
	git config --global http.proxy http://proxyuser:proxypwd@proxy.server.com:8080

	**EXEMPLO: (devem ser executado os DOIS comandos)**
	
	git config --global http.proxy http://RA:SenhaDoAluno@186.251.39.91:3128
	
	git config --global https.proxy https://RA:SenhaDoAluno@186.251.39.91:3128

		Se o seu RA é "12345" e sua senha é "OtimoAluno" o seu comando será:
			git config --global http.proxy http://12345:OtimoAluno@186.251.39.91:3128
			git config --global https.proxy https://12345:OtimoAluno@186.251.39.91:3128

		
	**Para ler o proxy configurado:**
	
	git config --global --get http.proxy
	
	git config --global --get https.proxy

	**Comando para LIMPAR as configurações do proxy (no final da aula):**
	
	git config --global --unset http.proxy
	
	git config --global --unset https.proxy
	
	
	
- **Passo 4 - Configurar os seus dados no git:**
	
	
	git config --global user.email "you@example.com"
	
	git config --global user.name "Your Name"
	
	
	
	    COMANDOS EXTRAS NO GIT BASH:
		
		ls = listar diretório
		clear = Limpar tela
		history -c = limpar comandos anteriores no terminal

	
	Para verificar os carateres especiais CASO necessite utilizar no PROXY.
	
	https://en.wikipedia.org/wiki/Percent-encoding
	
	
	
Pronto!  

O seu git está configurado.


----------------------------------------------------------------

## Para iniciar um projeto existente


 - **Passo 1 - Configure o seu GIT**
		
				
- **Passo 2 - Escolha o diretório de trabalho**
	
		Exemplo: 
			- cd e:
			- cd jogos
	
	
- **Passo 3 - Clonar repositorio remoto:**

	git clone https://github.com/laboratoriodejogos/grupo_arquivos.git   (exemplo)


Pronto!

O seu repositório já está configurado e pronto para uso.



--------------------------------------------------------------------


## Comandos do GIT

	Para criar um novo repositorio local:
	// para iniciar o repositório
	git init

	// para adicionar o versionamento aos arquivos criados ou  modificados
	git add * 

	// para listar os arquivos (se estão versionados ou não)
	git status
	
	// para determinar o repositorio remoto (destino dos arquivos)
	git remote add origin <Endereço do servidor>**

	// para efetivar as alterações no repositório local
	git commit -m "comentário_exemplo"

	// enviar os arquivos commitados para o repositório remoto
	git push origin master

	
	//Atualizar repositório (dentro do diretório versionado):
	git pull origin master
	
	
---------------------------------------------------------------------


## CONTEÚDO DE ESTUDO 

	Link com comandos de apoio para GIT
	- http://rogerdudler.github.io/git-guide/index.pt_BR.html
	- https://try.github.io/levels/1/challenges/1	

	- http://rogerdudler.github.io/git-guide/index.pt_BR.html
	- https://pt.wikipedia.org/wiki/Sistema_de_controle_de_vers%C3%B5es
	- https://www.youtube.com/watch?v=C18qzn7j4SM&list=PLQCmSnNFVYnRdgxOC_ufH58NxlmM6VYd1
	- https://www.youtube.com/watch?v=WVLhm1AMeYE&list=PLInBAd9OZCzzHBJjLFZzRl6DgUmOeG3H0
	- https://www.youtube.com/watch?v=UMhskLXJuq4	

	PUBLICAR WEB PAGE GIT
	- https://pages.github.com/
	- http://blog.virtuacreative.com.br/hospedar-website-gratis-com-github.html
	
    
	
	Comandos GIT Extras:
	- Criar arquivo .gitignore (listar arquivos a serem ignorados no versionamento)
		Entrar no site: https://www.gitignore.io/
		Escolher o tipo de arquivo, clicar em "Create" e salvar o arquivo exibido.
		Este arquivo ".gitignore" deve ester na raiz do projeto versionado



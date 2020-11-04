# coding: utf-8
# Desenvolvido pelo GRUPO X
# Código APS
 
import base64
from Crypto.Cipher import AES
from Crypto import Random
from Crypto.Cipher import DES3

#se o arquivo não for multiplo de 16, ele utiliza o próximo comando para preencher o espaço que falta com "{"
def pad(s):
	return s + '{' * (16 - len(s) % 16)

# Criptografa uma mensagem
def encrypt(raw):
	#chave que será utilizada na criptografia
	key = b'\xbf\xc0\x85)\x10nc\x94\x02)j\xdf\xcb\xc4\x94\x9d(\x9e[EX\xc8\xd5\xbfI{\xa2$\x05(\xd5\x18'
	#utiliza a função pad
	#raw = pad(raw)
	iv = Random.new().read(AES.block_size)
	#através da biblioteca random, juntamente com a criptografia em bloco, será criado uma saída aleatoria
	cipher = AES.new(key.encode('utf8'), AES.MODE_CBC, iv=iv.encode('utf8'))
	#criptografa a mensagem
	return base64.b32encode(iv + cipher.encrypt(raw))

# Descriptografa uma mensagem
def decrypt(enc):
	#chave que será utilizada na criptografia
	key = b'\xbf\xc0\x85)\x10nc\x94\x02)j\xdf\xcb\xc4\x94\x9d(\x9e[EX\xc8\xd5\xbfI{\xa2$\x05(\xd5\x18'
	enc = base64.b32decode(enc)
	iv = enc[:AES.block_size]
	#através da biblioteca random, juntamente com a criptografia em bloco, será criado uma saída aleatoria
	cipher = AES.new(key.encode('utf8'), AES.MODE_CBC, iv=iv.encode('utf8'))
	#descriptografa a mensagem
	dec = cipher.decrypt(base64.b32decode(message))
	#retira os caracters '{' da mensagem
	return dec.rstrip('{')

# Criptografa um arquivo
def encrypt_file(file_name):
	#chave que será utilizada na criptografia
	key = b'\xbf\xc0\x85)\x10nc\x94\x02)j\xdf\xcb\xc4\x94\x9d(\x9e[EX\xc8\xd5\xbfI{\xa2$\x05(\xd5\x18'
	iv = Random.new().read(AES.block_size)
	cipher = AES.new(key, AES.MODE_CBC, iv)

	#abre o arquivo para que possa ser mexido
	arq_entrada = open(file_name, "rb")
	arq_entrada = arq_entrada.read()

	#se o arquivo não for multiplo de 16, ele utiliza o próximo comando para preencher o espaço que falta com "{"
	cryptoSaida = pad(arq_entrada)

	#depois do arquivo se tornar multiplo de 16, nos o criptografamos, deixando os dados do arquivo em base64(método para codificação de dados)
	message_crypto = base64.b32encode(cipher.encrypt(cryptoSaida))

	#aqui nos criptogramos o titulo, fazendo tudo que foi feito antes
	titulo_crypto = base64.b32encode(cipher.encrypt(pad(file_name)))

	#abre o arquivo selecionado pelo usuario
	arq_saida = open(titulo_crypto,'wb')

	#escreve a criptografia no arquivo
	arq_saida.write(message_crypto)

	#fecha o arquivo
	arq_saida.close()

# Descriptografa um arquivo
def decrypt_file(file_name):
	key = b'\xbf\xc0\x85)\x10nc\x94\x02)j\xdf\xcb\xc4\x94\x9d(\x9e[EX\xc8\xd5\xbfI{\xa2$\x05(\xd5\x18'
	iv = Random.new().read(AES.block_size)
	cipher = AES.new(key, AES.MODE_CBC, iv)

	#le o arquivo que o usuario digitou
	arq_entrada = open(file_name, "rb")
	
	#comando a seguir decodifica os caracters e deixa na forma original
	arq_entrada = base64.b32decode(arq_entrada.read())
	
	# nessa parte nós recuperamos o nome do arquivo e retiramos os caracters adicionais "{"
	titulo_antigo = cipher.decrypt(base64.b32decode(file_name))
	titulo_antigo = titulo_antigo.rstrip('{')
	
	#vamos repetir o processo para o conteudo do arquivo
	texto_recuperado = cipher.decrypt(arq_entrada)
	texto_recuperado = texto_recuperado.rstrip('{')
	
	#e por fim vamos recriar o arquivo
	arq_saida2 = open(titulo_antigo,"wb")
	arq_saida2.write(texto_recuperado)

print("===========================================================================================================|")
print("Regras:                                                                                                    |")
print("1 - Nao digite frases com caracters especiais neste programa!!                                             |")
print("2 - Para Criptografar ou Descriptografar um arquivo, ele deve estar no mesmo local que o programa!!        |")
print("2.1 - Criptografar um arquivo de um diretorio qualquer, nao podera conter acentos e caracters especiais!!  |")
print("===========================================================================================================|\n")
print("**********************************************Sejá Bem-Vindo************************************************")
print("Voce esta utilizando o programa de Criptografia e Descriptografia Desenvolvido pelo Grupo X.")
print("Para iniciar-mos, escolha a opcao desejada:")

#pede para que o usuario digite a opção que ele deseja 
opcao = input("> A. Criptografar;\n> B. Descriptografar;\n> C. Sair;\n>>>").capitalize()

if opcao == "A":
	#pede para que o usuario digitar o tipo de criptografia que será usada
	tipo_crip = input("\nDigite o tipo de Criptografia que sera utilzada:\n> A. AES;\n> B. DES;\n>>>").capitalize()
	
	if tipo_crip == "A":
		print("\nCriptografia selecionada: AES!!")
		print("Digite o tipo de arquivo que deseja Criptografar:")

		#pede para que o usuario digitar o tipo de arquivo que será criptografado
		tipo_arq = input ("> A. Texto;\n> B. Arquivo;\n>>>").capitalize()

		try: #tente executar tal cadeia de comando, caso dê algum erro, ele irá mostrar o erro no comando "except Exception as e: print(e"

			if tipo_arq == "A":
				print("\nOpcao escolhida: Mensagem!!")

				#mensagem que o usuário irá digitar, para depois ser criptografa
				message = input("Digite a mensagem que sera Criptografada:")

				encrypted = encrypt(message)

				print("Mensagem:", message)
				print("Mensagem Criptografada:", encrypted)

			elif tipo_arq == "B":
				print("\nOpcao escolhida: Arquivo!!")

				#recebe o nome do arquivo que será criptografado
				arquivo = input("Digite o diretorio, o nome e a extensao do arquivo que deseja Criptografar:\nEX: Diretorio/Nome.Extensao:")

				encrypt_file(arquivo)
				print("Arquivo Criptografado com Sucesso!!\nPara visualizar tal arquivo, va para o diretorio onde esta sendo executado este programa!!")
			else:
				print("Error: Opcao Invalida!!")

		except Exception as e: print(e) #mostrar o erro

	elif tipo_crip == "B":
		print("\nCriptografia selecionada: DES!!")

	else:
		print("Error: Opcao Invalida!!")
	
elif opcao == "B":
	tipo_decrip = input("\nDigite o tipo de Descriptografia que sera utilizada:\n> A. AES;\n> B. DES;\n>>>").capitalize()

	if tipo_decrip == "A":
		print("\nCriptografia AES sera Descriptografada!!")
		print("Digite o tipo de arquivo que deseja Descriptografar:")

		#pede para que o usuario digitar o tipo de arquivo que será descriptografado
		tipo_arq = input ("> A. Texto;\n> B. Arquivo;\n>>>").capitalize()
		
		try:#tente executar tal cadeia de comando, caso dê algum erro, ele irá mostrar o erro no comando "except Exception as e: print(e"

			if tipo_arq == "A":
				print("\nOpcao escolhida: Mensagem!!")

				#recebe o nome da mensagem que será descriptografada
				message = input("Digite a mensagem que sera Descriptografada:")

				decrypted = decrypt(message)

				print("Mensagem Criptografada:",message)
				print("Mensagem Descriptografada:",decrypted)

			elif tipo_arq == "B":
				print("\nOpcao escolhida: Arquivo!!")

				#recebe o nome do arquivo que será criptografado
				arquivo = input("Digite o nome do arquivo Criptografada que deseja Descriptografar:\nNome:")
				
				decrypted = decrypt_file(arquivo)

				print("Arquivo Descriptografado com Sucesso!!\nPara visualizar tal arquivo, va para o diretorio onde esta sendo executado este programa!!")
			else:
				print("Error: Opcao Invalida!!")

		except Exception as e: print(e)#mostrar o erro

	elif tipo_decrip == "B":
		print("\nCriptografia DES sera Descriptografada!!")

	else:
		print("Error: Opcao Invalida!!")

elif opcao == "C":
	print("\nBye Bye!!")

else:
	print("Error: Opcao Invalida!!")
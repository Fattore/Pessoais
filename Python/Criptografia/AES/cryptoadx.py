#/usr/bin/env python
#coding: utf-8
# Desenvolvido pelo GRUPO X
# Código APS

import base64
from Crypto.Cipher import AES
from Crypto import Random
from Crypto.Cipher import DES3

print("=====================================================================================================|")
print("Regras:                                                                                              |")
print("1 - Nao digite frases com caracteres especiais neste programa!!                                      |")
print("2 - Para Criptografar ou Descriptografar um arquivo, ele deve estar no mesmo local que o programa!!  |")
print("=====================================================================================================|\n")
print("*******************************************Seja Bem-Vindo*********************************************")
print("Voce esta utilizando o programa de Criptografia e Descriptografia Desenvolvido pelo Grupo X.")
print("Para iniciar-mos, escolha a opcao desejada:")

#pede para que o usuario digite a opção que ele deseja 
opcao = raw_input("A = Criptografar;\nB = Descriptografar;\nC = Sair;\nOpcao:").capitalize()

if opcao == "A":
	#pede para que o usuario digitar o tipo de criptografia que será usada
	tipo_crip = raw_input("\nDigite o tipo de Criptografia que sera utilzada:\nA = AES;\nB = DES;\nOpcao:").capitalize()
	
	if tipo_crip == "A":
		print("\nCriptografia selecionada: AES!!")
		print("Digite o tipo de arquivo que deseja Criptografar:")

		#pede para que o usuario digitar o tipo de arquivo que será criptografado
		tipo_arq = raw_input ("A = Texto;\nB = Arquivo;\nOpcao:").capitalize()

		try: #tente executar tal cadeia de comando, caso dê algum erro, ele irá mostrar o erro no comando "except Exception as e: print(e"

			if tipo_arq == "A":
				print("\nOpcao escolhida: Mensagem!!")

				#criando uma chave de criptografia
				key = b'\xbf\xc0\x85)\x10nc\x94\x02)j\xdf\xcb\xc4\x94\x9d(\x9e[EX\xc8\xd5\xbfI{\xa2$\x05(\xd5\x18'

				#mensagem que o usuário irá digitar, para depois ser criptografa
				message = raw_input("Digite a mensagem que sera Criptografada:")
				cipher = AES.new(key)

				#aqui transformamos a string em multiplo de 16 e a convertemos para base64(método para codificação de dados)
				encrypted = base64.b32encode(cipher.encrypt(message + '{' * (16 - len(message) % 16)))

				print("Mensagem:", message)
				print("Mensagem Criptografada:", encrypted)

			elif tipo_arq == "B":
				print("\nOpcao escolhida: Arquivo!!")

				#criando uma chave de criptografia
				key = b'\xbf\xc0\x85)\x10nc\x94\x02)j\xdf\xcb\xc4\x94\x9d(\x9e[EX\xc8\xd5\xbfI{\xa2$\x05(\xd5\x18'
				cipher = AES.new(key, AES.MODE_ECB)

				#recebe o nome do arquivo que será criptografado
				arquivo = raw_input("Digite o nome e a extensao do arquivo que deseja Criptografar:\nNome.Extensao:")

				#lê o arquivo e corrige o tamanho dele, já que ele deve ser multiplo de 16 para funcionar
				arq_entrada = open(arquivo, "r")
				arq_entrada = arq_entrada.read()

				#se o arquivo não for multiplo de 16, ele utiliza o próximo comando para preencher o espaço que falta com "{"
				cryptoSaida = arq_entrada + '{' * (16 - len(arq_entrada) % 16)

				#depois do arquivo se tornar multiplo de 16, nos o criptografamos, deixando os dados do arquivo em base64(método para codificação de dados)
				message_crypto = base64.b32encode(cipher.encrypt(cryptoSaida))

				#aqui nos criptogramos o titulo, fazendo tudo que foi feito antes
				titulo_crypto = base64.b32encode(cipher.encrypt(arquivo + '{' * (16 - len(arquivo) % 16)))

				#abre o arquivo selecionado pelo usuario
				arq_saida = open(titulo_crypto,'w')

				#escreve a criptografia no arquivo
				arq_saida.write(message_crypto)

				print("Arquivo Criptografado com Sucesso!!")
				print("Para visualizar tal arquivo, va para o diretorio onde esta sendo executado este programa!!")

				#fecha o arquivo
				arq_saida.close()

			else:
				print("Error: Opcao Invalida!!")

		except Exception as e: print(e) #mostrar o erro

	elif tipo_crip == "B":
		print("\nCriptografia selecionada: DES!!")

	else:
		print("Error: Opcao Invalida!!")
	
elif opcao == "B":
	tipo_decrip = raw_input("\nDigite o tipo de Descriptografia que sera utilizada:\nA = AES;\nB = DES;\nOpcao:").capitalize()

	if tipo_decrip == "A":
		print("\nCriptografia AES sera Descriptografada!!")
		print("Digite o tipo de arquivo que deseja Descriptografar:")

		#pede para que o usuario digitar o tipo de arquivo que será descriptografado
		tipo_arq = raw_input ("A = Texto;\nB = Arquivo;\nOpcao:").capitalize()
		
		try:#tente executar tal cadeia de comando, caso dê algum erro, ele irá mostrar o erro no comando "except Exception as e: print(e"

			if tipo_arq == "A":
				print("\nOpcao escolhida: Mensagem!!")

				#criando uma chave de criptografia
				key = b'\xbf\xc0\x85)\x10nc\x94\x02)j\xdf\xcb\xc4\x94\x9d(\x9e[EX\xc8\xd5\xbfI{\xa2$\x05(\xd5\x18'

				#recebe o nome da mensagem que será descriptografada
				message = raw_input("Digite a mensagem que sera Descriptografada:")
				cipher = AES.new(key)
				
				#nessa função nós recuperamos o texto da string e retiramos os caracteres adicionais "{"
				dec = cipher.decrypt(base64.b32decode(message))
				decrypted = dec.rstrip('{')

				print("Mensagem Criptografada:",message)
				print("Mensagem Descriptografada:",decrypted)

			elif tipo_arq == "B":
				print("\nOpcao escolhida: Arquivo!!")

				#criando uma chave de criptografia
				key = b'\xbf\xc0\x85)\x10nc\x94\x02)j\xdf\xcb\xc4\x94\x9d(\x9e[EX\xc8\xd5\xbfI{\xa2$\x05(\xd5\x18'
				cipher = AES.new(key, AES.MODE_ECB)

				#recebe o nome do arquivo que será criptografado
				arquivo = raw_input("Digite o nome da imagem Criptografada que deseja Descriptografar:\nNome:")
			

				#le o arquivo que o usuario digitou
				arq_entrada = open(arquivo, "r")

				#comando a seguir decodifica os caracters e deixa na forma original
				arq_entrada = base64.b32decode(arq_entrada.read())

				# nessa parte nós recuperamos o nome do arquivo e retiramos os caracteres adicionais "{"
				titulo_antigo=cipher.decrypt(base64.b32decode(arquivo))
				titulo_antigo=titulo_antigo.rstrip('{')

				#vamos repetir o processo para o conteudo do arquivo
				texto_recuperado=cipher.decrypt(arq_entrada)
				texto_recuperado=texto_recuperado.rstrip('{')

				#e por fim vamos recriar o arquivo
				arq_saida2 = open(titulo_antigo,"w")
				arq_saida2.write(texto_recuperado)

				print("Arquivo Descriptografado com Sucesso!!")
				print("Para visualizar tal arquivo, va para o diretorio onde esta sendo executado este programa!!")

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
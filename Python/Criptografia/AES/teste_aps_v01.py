# -*- coding: UTF-8 -*-
# Morrillo Fattore
# prévia do código APS

from Crypto.Cipher import AES
#from Crypto.Cipher import DES3
#from Crypto import Random

def pad(s):
	return s + ((16 - len(s) % 16) * '{')

def encrypt(plaintext):
	global cipher
	return cipher.encrypt(pad(plaintext))

def decrypt(ciphertext):
	global cipher
	dec = cipher.decrypt(ciphertext).decode('utf-8')
	l = dec.count('{')
	return dec[:len(dec)-l]

print("Seja Bem-Vindo!")
print("Você está utilizando o programa de Criptografia e Descriptografia Desenvolvido pelo Grupo_X.")
print("Para iniciar-mos, escolha a opção desejada:")
opcao = raw_input("A = Criptografar;\nB = Descriptografar;\n").capitalize()

if opcao == "A":
	tipo_crip = raw_input("Digite o tipo de Criptografia que será utilzada:\nA = AES;\nB = DES;\n").capitalize()
	
	if tipo_crip == "A":
		print("Criptografia selecionada: AES")
		print("Digite o tipo de arquivo que deseja criptografar:")
		tipo_arq = raw_input ("A = Texto;\nB = Arquivo;\nC = imagem;\n").capitalize()
		
		if tipo_arq == "A":
			key = b'\xbf\xc0\x85)\x10nc\x94\x02)j\xdf\xcb\xc4\x94\x9d(\x9e[EX\xc8\xd5\xbfI{\xa2$\x05(\xd5\x18'
			message = raw_input("Digite a mensagem que será criptografada:")
			cipher = AES.new(key)

			global encryptedS
			encrypted = encrypt(message)

			print("Mensagem:", message)
			print("Mensagem Criptografada:", encrypted)

		elif tipo_arq == "B":
			print("arquivo")
		elif tipo_arq == "C":
			print("imagem")
		else:
			print("Error: Opção Inválida!!")
	elif tipo_crip == "B":
		print("Criptografia selecionada: DES")
	else:
		print("Error: Opção Inválida!!")
	
elif opcao == "B":
	tipo_decrip = raw_input("Digite o tipo de Descriptografia que será utilzada:\nA = AES;\nB = DES;\n").capitalize()
	print("Digite o tipo de arquivo que deseja descriptografar:")
	tipo_arq = raw_input("A = Texto;\nB = Arquivo;\nC = imagem;\n").capitalize()
	
	if tipo_arq == "A":
		key = b'\xbf\xc0\x85)\x10nc\x94\x02)j\xdf\xcb\xc4\x94\x9d(\x9e[EX\xc8\xd5\xbfI{\xa2$\x05(\xd5\x18'
		message = raw_input("Digite a mensagem que será descriptografada: ")
		cipher = AES.new(key)

		global decrypted
		decrypted = decrypt(encrypted)

		print("Decrypted:", decrypted)

		print (texto)
	elif tipo_arq == "B":
		print("arquivo")
	elif tipo_arq == "C":
		print("imagem")
	else:
		print("Error: Opção Inválida!!")
else:
	print("Error: Opção Inválida!!")
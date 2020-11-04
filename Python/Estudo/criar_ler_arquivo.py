# coding: utf-8

'''
r = somente leitura
w = escrita(caso o arquivo já exista, ele será apagado e se criará um novo)
a = leitura e escrita (adiciona o novo conteúdo ao fim do arquivo)
r+ = leitura e escrita
w+ = escrita(o modo w+, assim como o w, também apaga o contéudo anterior do arquivo)
a+ = leitura e escrita (abre o arquivo para update)
'''

# ler um arquivo existente com informações dentro
arquivo = open("arquivo.txt")
# abre o arquivo
'''
linhas = arquivo.readlines()
# lê cada linha

for linha in linhas:
	print(linha)
	# mostra cada linha

#Aqui ele printa uma coisa de cada vez
'''
texto_completo = arquivo.read()
# lê o arquivo todo

print(texto_completo)
# printa tudo de uma vez

# criar um arquivo a partir do zero 
criar_arquivo = open("arquivo2.txt","w") # explicação do w tá ali em cima

criar_arquivo.write("Esse é o meu arquivo, criado a partir do Python")
# método para escrever dentro do arquivo criado

criar_arquivo.close()
# sempre que você abre um arquivo, você abrigatóriamente deve fecha-lo depois
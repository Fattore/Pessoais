# coding: utf-8
# Murilo Fattore

b1 = float(input("Digite a nota de sua B1: ")) # float(input()) é a conversão de string para número real/quebrado
b2 = float(input("Digite a nota de sua B2: ")) # float(input()) é a conversão de string para número real/quebrado
media = (b1 + b2)/2
# calculo da média

if media >= 7:
	print("O aluno conseguiu a nota: {} !".format(media)) # .format() método para mostrar a variavel direto no texto
	print("Aluno aprovado para o próximo semestre!")
else:
	print("O aluno não foi aprovado com a nota da B1 e da B2!")
	exame = float(input("Digite a nota do exame: ")) # se o aluno não passou direto, ele entra dentro dessa linha de código
	
	media2 = (media + exame)/2
	# calculo da media total + o valor do exame

	if media2 >= 5:
		print("O aluno conseguiu a nota: {} !".format(media2)) # .format() método para mostrar a variavel direto no texto
		print("Aluno aprovado pelo exame!")
	else:
		print("O aluno conseguiu a nota: {} !".format(media2)) # .format() método para mostrar a variavel direto no texto
		print("Aluno reprovado!")

# por algum motivo a acentuação não está funcionando nesse código, mesme eu colocando a conversão apra UTF-8 no inicio dele :(
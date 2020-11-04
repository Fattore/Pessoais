# coding: utf-8
# operações com string

nome = "Morrilo"
s_nome = "Fattore"
n_completo = nome + " " + s_nome
print(n_completo)
#concatena as duas strings

print("")

m_mundo = "pneumoultramicroscopicossilicovulcanoconiótico"
count_l = len(m_mundo)
print("A palavra: {} \nTem {} Letras!".format(m_mundo,count_l))
# {} serve para usar o método .format(), o \n para quebrar linha, e o len() para contar a quantidade de linhas

print("")

print(m_mundo[24])
# ele anda pela string e printa a letra no número marcado

print("")

print(m_mundo[0:6])
# imprime apenas uma parte da string

print("")

m_mundo2 = "PNEUMOULTRAMICROSCOPICOSSILICOVULCANOCONIÓTICO"
print(m_mundo2.lower())
print("")
print(m_mundo.upper())
print("")
print(m_mundo.capitalize())
# método de maiusculo e minusculo

print("")

var_1 = "Um Dois Tres Quatro Dois Dois Tres Quatro Opa Eai Vei BLZ"
var_split = var_1.split()
print(var_split)
# converte minha string em uma lista

print("")

busca = var_1.find("Opa")
print(var_1[busca:])
# procura na string

print("")

var_2 = var_1.replace("Dois","AAAA")
print(var_2)
# substitui a palavra na string


Algoritmo "formula de bakka"

Var
n, raiz, a, b, c, d, xum, xdois: Real

Inicio
 Escreval ("Informe o valor de A")
 Escreval ("Informe o valor de B")
 Escreval ("Informe o valor de C")
 leia (a)
 leia (b)
 leia (c)
 d <- (b^2)*(-4*a*c)
 
 se d>=0 entao
 
 RaizQ (d)
 xum <- (-b + d)/(2*a)
 xdois <- (-b - d)/(2*a)
 
 Escreval ("Se x for positivo ele terá: ", xum, " como resultado")
 Escreval ("Se x for negativo ele terá: ", xdois, " como resultado")
 
 senao

 escreval("Raíz possui resultado negativo")
 fimse

Fimalgoritmo
//Murilo Gomes de Fattore e Brito
//F03HBG-3
package Exercicio6;

public class Preguica extends Animal {

    @Override
    public void emitirSom() {
        System.out.println("Iiihh!!");
    }

    @Override
    public void locomocao() {
        System.out.println("Preguiça subindo a arvore...");
    }
    
    public Preguica(){};
    
    public Preguica(String nome, int idade){
        this.nome = nome;
        this.idade = idade;
        this.nome = "Preguiça";
    }
}

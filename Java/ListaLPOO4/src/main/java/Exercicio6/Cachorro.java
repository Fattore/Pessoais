//Murilo Gomes de Fattore e Brito
//F03HBG-3
package Exercicio6;

public class Cachorro extends Animal {

    @Override
    public void emitirSom() {
        System.out.println("Au Au Au!!");
    }

    @Override
    public void locomocao() {
        System.out.println("Cachorro correndo...");
    }
    
    public Cachorro(){};
    
    public Cachorro(String nome, int idade){
        this.nome = nome;
        this.idade = idade;
    }
}

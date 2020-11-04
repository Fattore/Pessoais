//Murilo Gomes de Fattore e Brito
//F03HBG-3
package Exercicio6;

public class Cavalo extends Animal {

    @Override
    public void emitirSom() {
        System.out.println("Hiin in in!!");
    }

    @Override
    public void locomocao() {
        System.out.println("Cavalo trotando...");
    }
    
    public Cavalo(){};
    
    public Cavalo(String nome, int idade){
        this.nome = nome;
        this.idade = idade;
        this.nome = "Cavalo";
    }
}

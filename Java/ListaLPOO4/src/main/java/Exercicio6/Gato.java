//Murilo Gomes de Fattore e Brito
//F03HBG-3
package Exercicio6;

public class Gato extends Animal {

    @Override
    public void emitirSom() {
        System.out.println("Hiiisss!!");
    }

    @Override
    public void locomocao() {
        System.out.println("Gato andando...");
    }
    
    public Gato(){};
    
    public Gato(String nome, int idade){
        this.nome = nome;
        this.idade = idade;
        this.nome = "Gato";
    }    
}

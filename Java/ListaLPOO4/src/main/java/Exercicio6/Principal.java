//Murilo Gomes de Fattore e Brito
//F03HBG-3
package Exercicio6;

public class Principal {
    public static void main(String [] Args){
        Animal cachorro = new Cachorro(nome:"Lilla", idade:18);
        System.out.println(cachorro.nome);
        System.out.println(cachorro.idade);
        cachorro.emitirSom();
        cachorro.locomocao();
        
        Animal cavalo = new Cavalo(nome:"Maximus", idade:5);
        System.out.println(cavalo.nome);
        System.out.println(cavalo.idade);
        cachorro.emitirSom();
        cachorro.locomocao();        
        
        Animal preguica = new Preguica(nome:"Fred", idade:27);
        System.out.println(preguica.nome);
        System.out.println(preguica.idade);
        cachorro.emitirSom();
        cachorro.locomocao();
        
        Animal coelho = new Coelho(nome:"Haru", idade:18);
        System.out.println(coelho.nome);
        System.out.println(coelho.idade);
        cachorro.emitirSom();
        cachorro.locomocao();
 
        Animal gato = new Gato(nome:"Garfield", idade:35);
        System.out.println(gato.nome);
        System.out.println(gato.idade);
        cachorro.emitirSom();
        cachorro.locomocao();
        
        Animal macaco = new Macaco(nome:"Cesar", idade:18);
        System.out.println(macaco.nome);
        System.out.println(macaco.idade);
        cachorro.emitirSom();
        cachorro.locomocao();
        
        Veterinario vet = new Veterinario();
        vet.examinar(cachorro);
        vet.examinar(cavalo);
        vet.examinar(preguica);
        vet.examinar(coelho);
        vet.examinar(gato);
        vet.examinar(macaco);
        
        
    }    
}

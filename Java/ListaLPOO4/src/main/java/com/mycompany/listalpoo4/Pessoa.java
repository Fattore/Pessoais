//Murilo Gomes de Fattore e Brito
//F03HBG-3
package com.mycompany.listalpoo4;

public class Pessoa {
    
    Pessoa(){};//construtor default
    
    private String nome; 
    private String endereco; 
    private String telefone;
    
    public void setNome(String Nome){
        this.nome = Nome;
    }
    
    public String getNome(){
        return this.nome;
    }
    
    public void setEndereco(String Endereco){
        this.endereco = Endereco;
    }
    
    public String getEndereco(){
        return endereco;
    }

    public void setTelefone(String Telefone){
        this.telefone = Telefone;
    }
    
    public String getTelefone(){
        return telefone;
    }    
    
    public Pessoa(String Nome, String Endereco){
        this.nome = Nome;
        this.endereco = Endereco;
    }
    
    public Pessoa(String Nome, String Endereco, String Telefone){
        this.nome = Nome;
        this.endereco = Endereco;
        this.telefone = Telefone;
    }
}

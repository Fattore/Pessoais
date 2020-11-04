//Murilo Gomes de Fattore e Brito
//F03HBG-3
package com.mycompany.listalpoo4;

public class Operario extends Empregado {
    private double valorProducao;
    private double comissao;
    
    public void setValorProducao(double VALProducao){
        this.valorProducao = VALProducao;
    }
    
    public double getValorProducao(){
        return valorProducao;
    }

    public void setComissao(double Comissao){
        this.comissao = Comissao;
    }
    
    public double getComissao(){
        return comissao;
    }
    
    public double calcularComissao(){
        return getValorProducao() * (getComissao()/100);
    }
    
    @Override
    public double calcularSalario(){
        return calcularComissao() + super.calcularSalario();
    }      
}

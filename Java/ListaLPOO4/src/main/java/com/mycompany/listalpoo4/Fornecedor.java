//Murilo Gomes de Fattore e Brito
//F03HBG-3
package com.mycompany.listalpoo4;

public class Fornecedor extends Pessoa {
    private double valorCredito;
    private double valorDivida;

    public void setValorCredito(double credito){
        this.valorCredito = credito;
    }
    
    public double getValorCredito(){
        return valorCredito;
    }

    public void setValorDivida(double divida){
        this.valorDivida = divida;
    }
    
    public double getValorDivida(){
        return valorDivida;
    }
    
    public double obterSaldo(){
        return getValorCredito() - getValorDivida();
    }
}

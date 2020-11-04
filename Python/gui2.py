#coding = utf-8
from Crypto.Cipher import AES
def padding(str):
    while(len(str) % 16 != 0):
        str+=b'\0'
    return str

def encryptor(ciphertext, keyb):
    IV = 16 * b'\x00'
    #esse mode você pode colocar direto no lugar do decryptor
    mode = AES.MODE_CBC
    #ficaria: encryptor = AES.new(keyb, AES.MODE_CBC, iv)
    encryptor = AES.new(keyb, mode, IV=IV)
    textb = ciphertext.encode()
    textb2 = padding(textb)
    ciphertext = encryptor.encrypt(textb2)
    print("Texto: ", textb2.decode("utf-8"))
    print("Texto criptografado: ", ciphertext)
    return ciphertext


def decryptor(ciphertext, keyb):
    IV = 16 * b'\x00'
    #esse mode você pode colocar direto no lugar do decryptor
    mode = AES.MODE_CBC
    #ficaria: encryptor = AES.new(keyb, AES.MODE_CBC, iv)
    decryptor = AES.new(keyb, mode, IV=IV)
    decrypedtext = decryptor.decrypt(ciphertext)
    print("Texto criptografado: ", ciphertext)
    decrypedtext = decrypedtext.rstrip(b'\0')
    print(decrypedtext.decode("utf-8"))
    """o .decode(utf-8) serve para converter o texto em um encode legivel"""


def main():
    print("vc deseja encriptar ou descriptografar")
    entrada = input("encriptograr/descriptografar(e/d)").lower() #lower vai ser sempre minusculo, previne de dar erro
    generatekey = input("digite uma chave de 16 caracteres sendo eles letras ou numeros: ")
    keyb = generatekey.encode()
    if (entrada == "e"):
        encryptor(keyb)
    elif (entrada == "d"):
        #o erro está nesse ciphertext = encryptor(keyb), você basicamente está criptografando de novo o código já criptografado
        ciphertext = encryptor(keyb)
        decryptor(ciphertext, keyb)
    else:
        print("Entrada Inválida") #se ele digitar algo diferente, vem pra cá

if __name__ == "__main__":
    main()
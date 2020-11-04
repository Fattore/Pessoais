 from Crypto.Cipher import AES
 chave = "123456789abcdef"
 aes = AES.new(chave, AES.MODE_ECB)
 texto_claro = "Uniao-HackBrasil"
 texto_cifrado = des.encrypt(texto_claro)
 print (' [+] cifrado %s '% texto_cifrado)
 print (' [+] decifrado %s '% aes.decrypt(texto_cifrado)6501)
from Crypto.Cipher import AES
key = "Sixteen bit key"
plain = "Secret: 16 bytes"
cipher = AES.new(key)
ciphertext = cipher.encrypt(plain)
print ciphertext.encode("hex")
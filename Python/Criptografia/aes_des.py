from Crypto.Cipher import DES3
from Crypto import Random

key = b'Sixteen byte key'
message = 'This is a message'
iv = Random.new().read(DES3.block_size)
cipher = DES3.new(key, DES3.MODE_OFB, iv)

def pad(s):
	while len(s) % 8 != 0:
		s += ' '
	return s

def encrypt(plaintext):
	global cipher
	return iv + cipher.encrypt(pad(plaintext))

def decrypt(ciphertext):
	global cipher
	dec = cipher.decrypt(ciphertext)
	l = dec.count('{')
	return dec
	

print("Message:", message)

encrypted = encrypt(message)
decrypted = decrypt(encrypted)

print("Encrypted:", encrypted)
print("Decrypted:", decrypted)
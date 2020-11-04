from Crypto.Cipher import AES
from Crypto import Random

key = b'\xbf\xc0\x85)\x10nc\x94\x02)j\xdf\xcb\xc4\x94\x9d(\x9e[EX\xc8\xd5\xbfI{\xa2$\x05(\xd5\x18'
message = 'This is a message'
cipher = AES.new(key)

def pad(s):
	return s + ((16 - len(s) % 16) * '{')

def encrypt(plaintext):
	global cipher
	return cipher.encrypt(pad(plaintext))

def decrypt(ciphertext):
	global cipher
	dec = cipher.decrypt(ciphertext).decode('utf-8')
	l = dec.count('{')
	return dec[:len(dec)-l]

print("Message:", message)

encrypted = encrypt(message)
decrypted = decrypt(encrypted)

print("Encrypted:", encrypted)
print("Decrypted:", decrypted)
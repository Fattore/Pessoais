from Crypto import Random
from Crypto.Cipher import AES
from Crypto.Hash import SHA256
import os,sys
from os import listdir
from os.path import isfile, join

def pad(s):
    # Data will be padded to 16 byte boundary in CBC mode
    return s + b"\0" * (AES.block_size - len(s) % AES.block_size)

# Encrypt message with password
def encrypt(message, key, key_size=256):
    #Message is file data, this Pad will change data file to 16 Byte boundary to use in CBC mode of AES
    message = pad(message)
    # Generata iv with random of AES block_size : IV (byte string) - The initialization vector to use for encryption or decryption.
    iv = Random.new().read(AES.block_size)
    # Initial Data file with key(password has been hash), Mode of has, iv.
    # Cipher-Block Chaining (CBC). Each of the ciphertext blocks depends on the current and all previous plaintext blocks. An Initialization Vector (IV) is required.
    # The IV is a data block to be transmitted to the receiver. The IV can be made public, but it must be authenticated by the receiver and it should be picked randomly.
    cipher = AES.new(key, AES.MODE_CBC, iv)
    #return data file with encrypted data.
    return iv + cipher.encrypt(message)

# Decrypt message with password
def decrypt(ciphertext, key):
    #get Iv from encrypted data file
    iv = ciphertext[:AES.block_size]
    #initial new AES with key, Mode, iv
    cipher = AES.new(key, AES.MODE_CBC, iv)
    #decrypt Data file.
    plaintext = cipher.decrypt(ciphertext[AES.block_size:])
    return plaintext.rstrip(b"\0")

# Encrypt file
def encrypt_file(file_name, key):
	# Open file to get file Data
    with open(file_name, 'rb') as fo:
        plaintext = fo.read()
    # Encrypt plaintext with key has been hash by SHA256.
    enc = encrypt(plaintext, key)
    #write Encrypted file
    with open(file_name + ".enc", 'wb') as fo:
        fo.write(enc)

# Decrypt file
def decrypt_file(file_name, key):
    #read file to get encrypted data
    with open(file_name, 'rb') as fo:
        ciphertext = fo.read()
    # decrypt file with password has been hash by SHA256    
    dec = decrypt(ciphertext, key)
    #save decrypted file
    with open(file_name[:-4], 'wb') as fo:
        fo.write(dec)

# hash pasword to get 16 bytes key.
def getKey(password):
    # Use SHA256 to hash password for encrypting AES 
    hasher = SHA256.new(password.encode())
    return hasher.digest()

def main():
    choice = input("Please Select One of the following\n> 1. Encrypt Image \n> 2. Decrypt Image\n>>> ")
    if choice == "1":
        files = os.listdir(os.path.dirname(sys.argv[0]))
        print("list of files:")
        for i in files:
            print(i)
        filename = input("Enter the name of file to be encrypted >>> ")
        password = input("Enter the password >>>")
        encrypt_file(filename, getKey(password))
        print ("Done!\n" ,filename,"===>" ,filename+".enc")
        os.remove(filename)
    elif choice == "2":
        files = os.listdir(os.path.dirname(sys.argv[0]))
        print("list of files:")
        for i in files:
            print(i)
        filename = input("File to be decrypted > ")
        password = input("Password: ")
        decrypt_file(filename, getKey(password))
        print ("Done\n",filename,"==>", filename[:-4])
        os.remove(filename)
    else:
        print("No option Selected")
 
if __name__ == "__main__":
    main()
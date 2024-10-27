const { createCipheriv, randomBytes, createDecipheriv } = require('crypto');

/// Cipher 
const message = 'i like turtles';
const key = randomBytes(32);
const iv = randomBytes(16);

const cipher = createCipheriv('aes256', key, iv);

/// Encrypt
const encryptedMessage = cipher.update(message, 'utf8', 'hex')
                        + cipher.final('hex');



///  Decrypt
const decipher = createDecipheriv('aes256', key, iv);
const decryptedMessage = decipher.update(encryptedMessage, 'hex', 'utf8')
                        + decipher.final('utf8');

/// Printing results out
console.log(`initial message ${message}`);
console.log(`ciphered: ${encryptedMessage.toString('utf-8')}`);
console.log(`deciphered: ${decryptedMessage.toString('utf-8')}`);


// To implement in node, we import all of the above... iv stands for initialization vector which prevent identical sequences of text.

// We declare the initial vector as 16 randomBytes which will randomize the output when encrypted, so an identical sequence of text is never produces the exact same cipher text... Making it more difficult for an hacker to break the encryption

// Now we can use these values(message, key, iv) to create a cipher. Just like a hash, a cipher is dependent upon an algorithm
// Although encryption algorithms are inherently different than hashing algorithms... So you'll notice an entirely different set of options here
// AES stands for Advanced Encryption Standard

// You can use the cipher to encrypt a message by calling update or even multiple messages if you want.
// Then finish it off by calling cipher final and add that value to the end of the encrypted message 
// At the cipher final point, the cipher cna no longer be used to encrypt data


// Now to decipher, create a decipher object.. And do something similar to the cipher object



// A great thing about encryption is that different cipher texts will be generated as we keep on running the program.
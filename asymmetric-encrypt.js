const { publicEncrypt, privateDecrypt } = require('crypto');
const { publicKey, privateKey } = require('../Learning/keypair');

const message = 'the british are coming';


const encryptedData = publicEncrypt(
    publicKey,
    Buffer.from(message)
);

console.log(encryptedData.toString('hex'));


const decryptedData = privateDecrypt(
    privateKey,
    encryptedData
);

console.log(decryptedData.toString('utf-8'));



// We import public encrypt and private decrypt from node crypt
// And we also import the publicKey and privateKey we generated inside the keypair.js file

// After creating message, we encrypt the message(or put it in the mailbox) by combining the publicKey with the message itself. 
// In this case it needs to be in a buffer format that will encrypt it so that only the owner of the mailbox can read it.

// At some  point in the future the recipient may want to read the original message which can be done by calling private decrypt with the private key(unlock mailbox)


// Everything we run our program, we get a different encryptedData all for the same message: 'The british are coming'
const { createSign, createVerify } = require('crypto');
const { publicKey, privateKey } = require('../Learning/keypair');

const message = 'this data must be signed';

/// SIGN
const signer = createSign('rsa-sha256')

signer.update(message);

const signature = signer.sign(privateKey, 'hex');


/// VERIFY
const verifier = createVerify('rsa-sha256');

verifier.update(message);

const isVerified = verifier.verify(publicKey, signature, 'hex');


console.log(isVerified ? ':) fully verified, message was not tampered with' : 'verification failed, message has been tampered with');


// In node we can create a signature with a createSign function
// We pass in 2 algorithms for signing, we then attach the signature to the message and send it to someone
// when they get it, they can create a verifier, update the original message and verify the signature with the sender's public key
//  If the signature was forged or the message was changed, the verifier will fail
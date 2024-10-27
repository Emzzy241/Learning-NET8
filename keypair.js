const { generateKeyPairSync } = require('crypto');

const { privateKey, publicKey } = generateKeyPairSync('rsa',
    {
        modulusLength: 2048, // THe length of your key in bits
        publicKeyEncoding: {
            type: 'spki', // recommended to be 'spki' by the Node.js docs
            format: 'pem',
        },
        privateKeyEncoding: {
            type: 'pkcs8',
            format: 'pem',
            // cipher: 'aes-256-cbc',
            // passphrase: 'top-secret'
        },

    }
);

console.log(publicKey);
console.log(privateKey);

module.exports = {
    privateKey, publicKey
}

// The crypto system we used is rsa: RIVEST-SHAMIR-ADLEMAN, itsthe most common one
// We set the return format to pem: privacy enhanced mail. TO show us the keys in base 64 format
// You can also add a passphrase to your key for added security

// We can then export them from this file to put them to use

// Implementing a Hash in Nodejs
const { createHash } = require('crypto'); //importing the built-in module

// creating a string hash

function hash(input)
{
    return createHash('sha256').update(input).digest('hex'); 
    
    // defining the hashing algorithm we want to use, sha256 stands for Secure Hash Algorithm 2
    // sha256 returns a value(called digest) with 256 bits... The algorithm you choose here is important, choosing an algorithm like md5 to hash an API key, that is not secure at all...
    // As computers have become more faster and the internet more vast, the md5 has become obsolete(deprecated by NIST)
    // Remmeber, cryptography is always evolving
    // sha256 is a good option but an even better one is Argon2; 
    // After our hashing function, we can call update with the input value and then return an output by calling Digest(Digest == output), with the format we want to return, 
    // We can return a format like base64 or hexadecimal(hex)



}

// Compare two hashed passwords
let password = "hi-mom!";
const hash1 = hash(password);
console.log(hash1);

// Later, we update the variable to something different and compare the two
password = "hi-mom!";
const hash2 = hash(password);
const match = hash1 == hash2;

console.log(match ? ':) good password, and passwords match' : ':( password does not match');

// We know that the original value is the same if the two hashes match up


// This is very useful, but a hash by itself isn't actually sufficient for storing a password in a database

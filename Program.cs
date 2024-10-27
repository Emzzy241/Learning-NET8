using System;
using System.Globalization; // For importing the CultureInfo object type which returns type System.Globalization.Calendar
using System.Security.Cryptography;

namespace Learning;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hey there, lets learn Cryptography ;)");

        /* Today, I will be learning 7 cryptography concepts from Fireship on Youtube
        // Cryptography is the one thing that makes the internet secure, without the mysterious art of cryptography, there would be no secrets and no privacy in the digital world
        // Your emails, bank records and privacy will be easily hackable
        // Computers do exactly what you tell them to do, but sometimes we don't want them to do some certain things like expose private data
        
        // Cryptography can take some useful bytes of data, then scramble them up with an algorithm making it nearly impossible for a computer to understand its true meaning without the proper credentials

        // Lets learn 7 useful cryptography concepts that every developers should know
        // 1. HASH 2. SALT 3. HMAC 4. SYMMETRIC ENCRYPTION 5. KEYPAIRS 6. SIGNING 7. ASSYMETRIC ENCRYPTION

        // Cryptography is the science of creating secrets, it has been around long before the computer, since 1900 BC
        // Crytography is awlasys evolving, what is considered safe and secret today may not be the case tomorrow.
        // As a devloper you don't need to understand all the complex math that goes into cryptography but it is essential to understand how certain key concepts work like Hashing, Encryption, and Signing etc.

        */

        // 1. HASH: The hash word means to chop and mix.... Thats what an hasing function does
        // You start with an input(it can be any length), then pass it off to a hashing function. This function returns a fixed length value of what looks like just meaningless gabbage
        // The important thing here is that he function would always produce the same output given the same input, it needs to be fast to compute and the output should be unique
        // However it is very difficult for a computer to reverse engineer what the initial message was.
        // Hash is really useful because it allows developers to store data without needing to know its true value, 
        // A simple example is not to storing a password in a database but a PasswordHash, this is becase if an hacker gets a hold of the database, they can put those passwords to use
        // But if the data is hashed, then they have to also crash that hash to figure out what the true password is:
        // I already implemented the HASH in Javascript
        // Hash isn't rally sufficient for storing a password in a database

        // 2. SALT: The fact that a hashing function always returns the same value is a very big problem when it comes to passwords
        // Users can use can come up with passwords as simple as: password123... If a hacker obtains the database and the passwords are hashed
        // They can just go to something like a rainbow table that has a bunch of precomputed hashes and find a bunch of commonly used passwords
        // A Salt is just a random value that is added to the password before it is hashed, therfore making it much harder to get

        // A common topic you might find is HMAC
        // 3. HMAC: Hash-Based Message Authentication Code, this is a hash that also requires a password
        // So the only person that can create the same hash signature must also have the corresponding passwords or key.
        // An example of HMAC is J-W-T(Json web token) for authentication on the web.
        // When a user logs in on a trusted server it generates a token with its key, then the client and server can pass it back and forth.. The client can be google chrome and the server can be nodejs or kestrel for .net
        // The server can trust it because it knows that only someone with a trusted key could have generated that hash signature.

    
        // The above is pretty cool, but what happens when you want to share a secret with someone but you also want to allow them to read the original message
        // Thats where Encryption comes in
        // With encryption, we take a message, scramble up the bytes to make it unreadable that is called the cipher text, then provide a key or password allowing somebody else to decrypt it.
        // cipher text is randomized so that each time you encrypt, you get an entirely different output even if the key and message are the same
        // There are many times of encryption...
        // 4. Symmetric encryption: Symmetric means that there is a shared password that both the sender and receiver of the message will need
        // To implement it in node, checkout symmetric-encrypt.js
    
        
        //5. KeyPair
        // A big limitation in symmetric encryption is the sharing of keys i.e both sender and receiver of message needs to share a password
        // And that is not very practical for 2 different parties to agree upon a shared password.. once again math comes to the rescue this time 
        // in the form of a public-key cryptosystem, instead of one key it uses 2 keys that are mathematically linked, a public key and a private key
        // private key is kept secret while public key can be shared with other perople
        // An analogy is a mailbox, anybody can drop you a mail inside a slot(a public key) but to get the mail out you need a private key which can only be dones by the owner of the key


        // 6. Asymmetric Encryption
        // You use Asymmetric encryption anytime you go to a website using https
        // The browser will automatically find a public key of an SSL certificate installed on the website
        // That public key is used to encrypt any data that you send to the website, that prevents hackers from gaining anything useful from it in transit
        // Your data is then decrypted using a private key by the trusted website
        // Check the asymmetric-encrypt.js file on how to implement it in node 

        // 7. Signing
        // Encryption is fun but in many cases you don't have to encrypt data but rather validate that the data came from a trusted party
        // That's where signing comes in... A digital signature analogy; Imagine you are expecting a letter in the mail with some sensitive information
        // You need to be able to trust that that letter came from the right person. So you require them to sign it in blood, it also can't be tampered with so they put a special seal on it that if broken it indicates that its been tampered with
        // Digital signatures work this way
        // The sender of message will use their private key to sign a hash of the original message, the private key guarantees authenticity like blood and the hash guarantees
        // that the message can't be tampered with because it will produce an entirely different signature
        // The recipient can can then use the public key to validate the authenticity of the message 

    }    
}
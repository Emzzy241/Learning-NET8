const { scryptSync, randomBytes, timingSafeEqual } = require('crypto');

let email = "emzzyoluwole@gmail.com";
let password = "Dynasty444$#";

function signup(email, password)
{
    const salt = randomBytes(16).toString('hex');
    const hashedPassword = scryptSync(password, salt, 64);
    // when user signs up we generate a salt; which is just a random set of characters, then we use s scrypt to hash it
    // We provide the scrypt with the original password and salt and provide a key length which is recommended to be 64
    // To avoid complex details, s scrypt makes it more computationally intensive to crack with brute force; 
    // And salt has been used as a proof of work algorithm in cryptocurrency mining

    const user = {email, password: `${salt}:${hashedPassword}`}
    // storing the salt with the hashpassword in the database by prepending it.
}

function login(email, password)
{
    const user = users.find(v => v.email === email);

    const [salt, key] = user.password.split(':');
    const hashedBuffer = scryptSync(password, salt, 64);

    const keyBuffer = Buffer.from(key, 'hex');
    const match = timingSafeEqual(hashedBuffer, keyBuffer);

    if(match)
    {
        return 'login success!';
    }
    else
    {
        return 'login failed!';
    }
    // Now when user logs in, we can grab the salt from the database and recreate the original hash, we could just compare the strings here but as an added touch, we used the timingsafeEqual function from node crypto
    // timingSafeEqual function prevents timing attacks, where a hacker measures the amount of time it takes to perform an operation to obtain information about the value
    // this function helps prevent that type of attack

    // That's how basic email password authentication works on the web.
    // This code cannot run here because there is no actual database called users
    // But you can implement it in other applications.
}

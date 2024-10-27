const { createHmac } = require('crypto');

const key = 'super-secret!';
const message = 'I am Dynasty';

const hmac = createHmac('sha256', key).update(message).digest('hex');

console.log(hmac);

const key2 = 'other-password';
const hmac2 = createHmac('sha256', key2).update(message).digest('hex');

console.log(hmac2);

// We We import createHmac function, then define a secret key, along with a message that we want to hash
// We can create a hash, like we did in hash.js; the slight difference is we also provide this key
// An important thing to notice is that we get the same hash when the same password is used, but if a different password is used, we get an entirely different hash
// Remember, Hmac is very similar to hash function, the key difference is the 'password or key'... By running the code above, w
// We get 2 different hashes and this is because we have different keys trying to access that message

// Whe
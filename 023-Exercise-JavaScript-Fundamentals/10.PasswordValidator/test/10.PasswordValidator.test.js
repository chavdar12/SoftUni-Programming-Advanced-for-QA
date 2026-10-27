import { expect } from 'chai';
import { captureLog } from '../../../captureLog.js';
import { solve as passwordValidator } from '../10.PasswordValidator.js';

describe('10.PasswordValidator', () => {
    it('10 validates passwords', () => {
        expect(captureLog(() => passwordValidator('MyPass123'))).to.deep.equal(['Password is valid']);
        expect(captureLog(() => passwordValidator('logIn'))).to.deep.equal([
            'Password must be between 6 and 10 characters',
            'Password must have at least 2 digits'
        ]);
        expect(captureLog(() => passwordValidator('Pa$s$s'))).to.deep.equal([
            'Password must consist only of letters and digits',
            'Password must have at least 2 digits'
        ]);
    });
});

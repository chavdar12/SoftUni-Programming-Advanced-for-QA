import { expect } from 'chai';
import { captureLog } from '../../../captureLog.js';
import { solve as numbersMToN } from '../10.NumbersFromMToN.js';

describe('10.NumbersFromMToN', () => {
    it('10 prints the numbers from M down to N', () => {
        expect(captureLog(() => numbersMToN(6, 2))).to.deep.equal(['6', '5', '4', '3', '2']);
    });
});

import { expect } from 'chai';
import { captureLog } from '../../../captureLog.js';
import { solve as numbers1To5 } from '../09.NumbersFrom1To5.js';

describe('09.NumbersFrom1To5', () => {
    it('09 prints the numbers from 1 to 5', () => {
        expect(captureLog(() => numbers1To5())).to.deep.equal(['1', '2', '3', '4', '5']);
    });
});

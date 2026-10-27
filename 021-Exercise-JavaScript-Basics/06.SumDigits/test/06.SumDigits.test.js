import { expect } from 'chai';
import { captureLog } from '../../../captureLog.js';
import { solve as sumDigits } from '../06.SumDigits.js';

describe('06.SumDigits', () => {
    it('06 sums the digits', () => {
        expect(captureLog(() => sumDigits(245678))).to.deep.equal(['32']);
    });
});

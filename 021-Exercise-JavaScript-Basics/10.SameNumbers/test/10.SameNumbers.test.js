import { expect } from 'chai';
import { captureLog } from '../../../captureLog.js';
import { solve as sameNumbers } from '../10.SameNumbers.js';

describe('10.SameNumbers', () => {
    it('10 checks for identical digits and sums them', () => {
        expect(captureLog(() => sameNumbers(2222222))).to.deep.equal(['true', '14']);
        expect(captureLog(() => sameNumbers(1234))).to.deep.equal(['false', '10']);
    });
});

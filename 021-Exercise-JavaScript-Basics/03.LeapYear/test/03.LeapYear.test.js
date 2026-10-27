import { expect } from 'chai';
import { captureLog } from '../../../captureLog.js';
import { solve as leapYear } from '../03.LeapYear.js';

describe('03.LeapYear', () => {
    it('03 detects leap years', () => {
        expect(captureLog(() => leapYear(1984))).to.deep.equal(['yes']);
        expect(captureLog(() => leapYear(1900))).to.deep.equal(['no']);
        expect(captureLog(() => leapYear(2000))).to.deep.equal(['yes']);
    });
});

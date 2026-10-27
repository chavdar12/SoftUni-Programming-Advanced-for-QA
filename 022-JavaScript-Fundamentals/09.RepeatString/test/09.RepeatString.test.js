import { expect } from 'chai';
import { captureLog } from '../../../captureLog.js';
import { solve as repeatString } from '../09.RepeatString.js';

describe('09.RepeatString', () => {
    it('09 repeats a string', () => {
        expect(captureLog(() => repeatString('abc', 3))).to.deep.equal(['abcabcabc']);
    });
});

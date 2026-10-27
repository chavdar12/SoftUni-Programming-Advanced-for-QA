import { expect } from 'chai';
import { captureLog } from '../../../captureLog.js';
import { solve as arrayRotation } from '../01.ArrayRotation.js';

describe('01.ArrayRotation', () => {
    it('01 rotates the array left', () => {
        expect(captureLog(() => arrayRotation([51, 47, 32, 61, 21], 2))).to.deep.equal(['32 61 21 51 47']);
    });
});

import { expect } from 'chai';
import { captureLog } from '../../../captureLog.js';
import { solve as towns } from '../12.Towns.js';

describe('12.Towns', () => {
    it('12 formats town coordinates', () => {
        expect(captureLog(() => towns(['Sofia | 42.696552 | 23.32601'])))
            .to.deep.equal(["{ town: 'Sofia', latitude: '42.70', longitude: '23.33' }"]);
    });
});

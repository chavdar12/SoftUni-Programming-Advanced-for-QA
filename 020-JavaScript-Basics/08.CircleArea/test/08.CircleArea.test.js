import { expect } from 'chai';
import { captureLog } from '../../../captureLog.js';
import { solve as circleArea } from '../08.CircleArea.js';

describe('08.CircleArea', () => {
    it('08 calculates circle area only for numbers', () => {
        expect(captureLog(() => circleArea(5))).to.deep.equal(['78.54']);
        expect(captureLog(() => circleArea('name')))
            .to.deep.equal(['We can not calculate the circle area, because we receive a string.']);
    });
});

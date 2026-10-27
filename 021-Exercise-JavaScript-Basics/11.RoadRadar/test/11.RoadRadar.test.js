import { expect } from 'chai';
import { captureLog } from '../../../captureLog.js';
import { solve as roadRadar } from '../11.RoadRadar.js';

describe('11.RoadRadar', () => {
    it('11 reports speeding by zone', () => {
        expect(captureLog(() => roadRadar(40, 'city'))).to.deep.equal(['Driving 40 km/h in a 50 zone']);
        expect(captureLog(() => roadRadar(21, 'residential')))
            .to.deep.equal(['The speed is 1 km/h faster than the allowed speed of 20 - speeding']);
        expect(captureLog(() => roadRadar(120, 'interstate')))
            .to.deep.equal(['The speed is 30 km/h faster than the allowed speed of 90 - excessive speeding']);
        expect(captureLog(() => roadRadar(200, 'motorway')))
            .to.deep.equal(['The speed is 70 km/h faster than the allowed speed of 130 - reckless driving']);
    });
});

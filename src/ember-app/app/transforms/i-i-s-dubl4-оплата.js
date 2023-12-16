import FlexberryEnum from 'ember-flexberry-data/transforms/flexberry-enum';
import ОплатаEnum from '../enums/i-i-s-dubl4-оплата';

export default FlexberryEnum.extend({
  enum: ОплатаEnum,
  sourceType: 'IIS.Dubl4.Оплата'
});

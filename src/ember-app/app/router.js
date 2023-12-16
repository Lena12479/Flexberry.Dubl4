import EmberRouter from '@ember/routing/router';
import config from './config/environment';

const Router = EmberRouter.extend({
  location: config.locationType
});

Router.map(function () {
  this.route('i-i-s-dubl4-заказ-l');
  this.route('i-i-s-dubl4-заказ-e',
  { path: 'i-i-s-dubl4-заказ-e/:id' });
  this.route('i-i-s-dubl4-заказ-e.new',
  { path: 'i-i-s-dubl4-заказ-e/new' });
});

export default Router;
